using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_Seg_SBD
{
    class Cadastro
    {
        // Propriedades (campos da classe):
        public int PessoaId { get; set; }
        public string PessoaNome { get; set; }
        public string PessoaTelefone { get; set; }

        // String de conexção com BD:
        readonly string strConexao = @"Data Source=DESKTOP-U84PPK5\SQLEXPRESS;Initial Catalog=2020_Seg_SBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Instruções SQL:
        public const string strINSERT = "INSERT INTO tb_Cliente (PessoaNome, PessoaTelefone) " +
            "VALUES( @PessoaNome, @PessoaTelefone); ";
        public const string strSELECT = "SELECT * FROM tb_Cliente; ";

        public void Gravar()
        {
            using (SqlConnection oConn = new SqlConnection(strConexao) )
            {
                using(SqlCommand oCmd = new SqlCommand(strINSERT, oConn))
                {
                    oCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                    oCmd.Parameters.AddWithValue("@PessoaTelefone", PessoaTelefone);

                    oConn.Open();
                    oCmd.ExecuteNonQuery();
                    oConn.Close();

                }
            }
        }

    }
}
