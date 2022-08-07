using System.Data;
using System.Text.RegularExpressions;

namespace Oraculo
{
    public class DataImportation
    {
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            try
            {
                StreamReader sr = new StreamReader(strFilePath);
                string[] headers = sr.ReadLine().Split(';');
                DataTable dt = new DataTable();
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = Regex.Split(sr.ReadLine(), ";(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

                if (dt.Columns[0].ColumnName == "NOME"
                //|| dt.Columns[0].ColumnName == "CNPJ"
                //|| dt.Columns[0].ColumnName == "NOME_CLIENTE"
                //|| dt.Columns[0].ColumnName == "CNPJ_CLIENTE"
                //|| dt.Columns[0].ColumnName == "TITULO"
                //|| dt.Columns[0].ColumnName == "EMISSAO"
                //|| dt.Columns[0].ColumnName == "VENCIMENTO"
                //|| dt.Columns[0].ColumnName == "TIT_VALORI"
                //|| dt.Columns[0].ColumnName == "LOGRADOURO"
                //|| dt.Columns[0].ColumnName == "BAIRRO"
                //|| dt.Columns[0].ColumnName == "CEP"
                //|| dt.Columns[0].ColumnName == "CIDADE"
                //|| dt.Columns[0].ColumnName == "CUF_ESIGLA"
                //|| dt.Columns[0].ColumnName == "SAI_CHANFE"
                //|| dt.Columns[0].ColumnName == "END_NUMTEL"
                //|| dt.Columns[0].ColumnName == "PEDIDOS"
                  )
                {
                    return dt;
                }
                else
                {
                    throw new Exception("Arquivo não está no padrão correto\nÉ esperado 18 colunas começando com NOME e terminando com PEDIDOS!");
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("because it is being used by another process"))
                {
                    throw new Exception("Verifique se o arquivo selecionado está em uso, caso esteja feche a aplicação que está usando o arquivo!");
                }

                throw ex;
            }
        }
    }
}
