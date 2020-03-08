using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MyFinance.Util;
using System.Data;

namespace MyFinance.Models
{
    public class PlanoContaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a Descrição!")]
        public string Descricao { get; set; }
        public string tipo { get; set; }
        public int Usuario_Id { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }


        public PlanoContaModel()
        {

        }

        private string IdUsuarioLogado()
        {
            return HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
        }

        public PlanoContaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<PlanoContaModel> ListaPlanoConta()
        {
            List<PlanoContaModel> lista = new List<PlanoContaModel>();
            try
            {

                string sql = $"SELECT ID,DESCRICAO,TIPO,USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = {IdUsuarioLogado()}";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PlanoContaModel item = new PlanoContaModel();
                    item.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                    item.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                    item.tipo = dt.Rows[i]["TIPO"].ToString();
                    item.Usuario_Id = Convert.ToInt32(dt.Rows[i]["USUARIO_ID"]);
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + e.InnerException.Message + ").");
            }
        }

        public PlanoContaModel CarregarRegistro(int id)
        {
            PlanoContaModel planoConta = new PlanoContaModel();
            try
            {
                
                string sql = $"SELECT ID,DESCRICAO,TIPO,USUARIO_ID FROM PLANO_CONTAS WHERE USUARIO_ID = {IdUsuarioLogado()} AND ID = {id}";
                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(sql);

                planoConta.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
                planoConta.Descricao = dt.Rows[0]["DESCRICAO"].ToString();
                planoConta.tipo = dt.Rows[0]["TIPO"].ToString();
                planoConta.Usuario_Id = Convert.ToInt32(dt.Rows[0]["USUARIO_ID"]);

                return planoConta;
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
                
                string sql = "";

                if (Id == 0)
                    sql = $"INSERT INTO PLANO_CONTAS (DESCRICAO,TIPO,USUARIO_ID) VALUES ('{Descricao}','{tipo}',{IdUsuarioLogado()})";
                else
                    sql = $"UPDATE PLANO_CONTAS SET DESCRICAO ='{Descricao}',TIPO ='{tipo}' WHERE USUARIO_ID = {IdUsuarioLogado()} AND ID = {Id}";

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
                string sql = "DELETE FROM PLANO_CONTAS WHERE ID = " + id_conta;
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
