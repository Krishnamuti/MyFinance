using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MyFinance.Util;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o nome da Conta!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o saldo")]
        public double Saldo { get; set; }
        public int UsuarioId { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public ContaModel()
        {

        }

        public ContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<ContaModel> ListarConta()
        {
            List<ContaModel> lista = new List<ContaModel>();
            try
            {
                string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
                string sql = $"SELECT ID,NOME,SALDO,USUARIO_ID FROM CONTA WHERE USUARIO_ID = {id_usuario_logado}";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ContaModel item = new ContaModel();
                    item.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                    item.Nome = dt.Rows[i]["NOME"].ToString();
                    item.Saldo = Convert.ToDouble(dt.Rows[i]["SALDO"]);
                    item.UsuarioId = Convert.ToInt32(dt.Rows[i]["USUARIO_ID"]);
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + e.InnerException.Message + ").");
            }
        }

        public void Insert()
        {
            
            try
            {
                string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
                string sql = $"INSERT INTO CONTA (NOME,SALDO,USUARIO_ID) VALUES ('{Nome}','{Saldo}',{id_usuario_logado})";
                DAL objDAL = new DAL();
                objDAL.ExecutarComandoSql(sql);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + e.InnerException.Message + ").");
            }
        }

        public void Excluir(int id_conta)
        {

            try
            {                
                string sql = "DELETE FROM CONTA WHERE ID = " + id_conta;
                DAL objDAL = new DAL();
                objDAL.ExecutarComandoSql(sql);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + e.InnerException.Message + ").");
            }
        }

    }
}
