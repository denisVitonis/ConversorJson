using System;
using System.Collections.Generic;
using System.IO;

namespace ConversorJson
{
    public static class Conversor
    {
        public static string ConvertToJSON(string csvContent, string entidade, string competencia)
        {
            // Dividir o conteúdo do CSV em linhas e converter para matriz
            string[] csvRows = csvContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            List<string[]> rows = new List<string[]>();

            foreach (string row in csvRows)
            {
                // Remover espaços extras e caracteres de formatação estranhos
                string cleanedRow = row.Replace("\"", "").Replace("'", "").Trim();
                rows.Add(cleanedRow.Split(';')); // Assumindo que o CSV é separado por ;
            }

            Dictionary<string, object> json = new Dictionary<string, object>
            {
                { "entidade", entidade },
                { "competencia", competencia },
                { "reclamacoes", new List<Dictionary<string, object>>() }
            };

            string[] header = rows[0]; // O primeiro elemento é o cabeçalho
            rows.RemoveAt(0); // Remover o cabeçalho da lista

            int registro = 1; // Inicializar contador de registro

            foreach (string[] row in rows)
            {
                if (row.Length == header.Length)
                {
                    Dictionary<string, object> item = new Dictionary<string, object>();

                    for (int i = 0; i < header.Length; i++)
                    {
                        string key = header[i].Replace(" ", ""); // Remover espaços no nome da chave
                        string value = row[i];

                        // Tratar datas substituindo "/" por "-"
                        if (key.ToLower().Contains("data"))
                        {
                            value = value.Replace("/", "-");
                        }

                        // Verificar se a chave já existe no dicionário
                        string originalKey = key;
                        int count = 1;
                        while (item.ContainsKey(key))
                        {
                            key = $"{originalKey}_{count++}";
                        }

                        // Tratamento especial para as chaves mencionadas
                        if (key == "motivo" || key == "canalVenda" || key == "status" || key == "canalReclamacao" || key == "assunto" || key == "tipo" || key == "registro")
                        {
                            if (int.TryParse(value, out int intValue))
                            {
                                item[key] = intValue;
                            }
                            else
                            {
                                Console.WriteLine($"Erro: Valor inválido para a chave {key} na linha {registro + 1}.");
                                return null;
                            }
                        }
                        else
                        {
                            item[key] = value;
                        }

                        Console.WriteLine($"Chave: {key}, Valor: {value}");
                    }

                    // Adicionar os detalhes do reclamante
                    Dictionary<string, object> reclamante = new Dictionary<string, object>
                    {
                        { "nome", item["nome"] },
                        { "identificacaoReclamante", item["identificacaoReclamante"] },
                        { "cep", item["cep"] },
                        { "sexo", item["sexo"] },
                        { "tipo", item["tipo"] },
                        { "dataNascimento", item["dataNascimento"] }
                    };

                    item["reclamante"] = reclamante;

                    // Remover campos desnecessários
                    item.Remove("nome");
                    item.Remove("identificacaoReclamante");
                    item.Remove("cep");
                    item.Remove("sexo");
                    item.Remove("tipo");
                    item.Remove("dataNascimento");
                    item.Remove("entidade");
                    item.Remove("competencia");

                    // Adicionar a reclamação ao array de reclamações
                    ((List<Dictionary<string, object>>)json["reclamacoes"]).Add(item);
                }
                else
                {
                    Console.WriteLine($"Erro: Número de colunas inconsistentes na linha {registro + 1}.");
                    Console.WriteLine($"Dados da linha {registro + 1}: {string.Join(", ", row)}");
                    return null;
                }

                registro++;
            }

            if (((List<Dictionary<string, object>>)json["reclamacoes"]).Count == 0)
            {
                Console.WriteLine("Erro: Nenhum dado encontrado.");
                return null;
            }

            // Converter para JSON
            string jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(json, Newtonsoft.Json.Formatting.Indented);

            // Defina o caminho para o arquivo JSON na pasta "arquivos_convertidos"
            string pastaArquivosConvertidos = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "arquivos_convertidos");
            Directory.CreateDirectory(pastaArquivosConvertidos); // Certifique-se de que a pasta existe

            string nomeArquivo = $"arquivo_{entidade}_{competencia}.json";
            string caminhoArquivo = Path.Combine(pastaArquivosConvertidos, nomeArquivo);

            // Salve o JSON no arquivo
            File.WriteAllText(caminhoArquivo, jsonText); // Certifique-se de que a pasta existe

            string mensagem = $"ARQUIVO GERADO COM SUCESSO NA PASTA : {pastaArquivosConvertidos}";
            Console.WriteLine(mensagem);

            return mensagem;
        }
    }
}
