using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFinance.Util;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Preencha o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o seu Email!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha a Senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preencha a Data de Nascimento!")]
        public string Data_Nascimento { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT U.Id,U.Nome,U.Data_Nascimento FROM usuario U WHERE U.Email = '{Email}' AND U.Senha = '{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = new DataTable();
            dt = objDAL.RetDataTable(sql);

            if(dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Data_Nascimento = dt.Rows[0]["Data_Nascimento"].ToString();
                    return true;
                }                    
            }

            return false;

        }

        public void RegistrarUsuario()
        {
            string dataNascimento = Convert.ToDateTime(Data_Nascimento).ToString("yyyy/MM/dd");
            string sql = $"INSERT INTO USUARIO (NOME,EMAIL,SENHA,DATA_NASCIMENTO) VALUES ('{Nome}','{Email}','{Senha}','{dataNascimento}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSql(sql);
        }


    }
}
