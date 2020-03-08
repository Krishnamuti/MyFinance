using Microsoft.AspNetCore.Http;
using MyFinance.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class TransacaoModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Informe a Data!")]
        public string Data { get; set; }
        public string DataFinal { get; set; } // utilizado para filtors
        public string Tipo { get; set; }
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe a Descrição!")]
        public string Descricao { get; set; }

        public int Conta_Id { get; set; }
        public string NomeConta { get; set; }
        public int Plano_Contas_Id { get; set; }
        public string DescricaoPlanoConta { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }


        public TransacaoModel()
        {

        }        

        public TransacaoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }


        public List<TransacaoModel> ListaTransacao()
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            try
            {
                string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
                StringBuilder stb = new StringBuilder();

                string filtro = "";
                if ((Data != null) && (DataFinal != null))
                {
                    filtro += $" and t.data >='{DateTime.Parse(Data).ToString("yyyy/MM/dd")}' and t.data <= '{DateTime.Parse(DataFinal).ToString("yyyy/MM/dd")}'";
                }

                if (!String.IsNullOrEmpty(Tipo) && Tipo != "A")
                    filtro += $" and t.tipo = '{Tipo}' ";

                if (Conta_Id != 0)
                    filtro += $" and t.conta_id = '{Conta_Id}' ";

                stb.Append("select t.id,t.data,t.tipo,t.valor,t.descricao historico,t.conta_id,c.nome conta,t.plano_contas_id, p.descricao plano_conta")
                   .Append(" from transacao t inner join conta c on t.conta_id = c.id")
                   .Append(" inner join plano_contas p on t.plano_contas_id = p.id")
                   .Append($" where t.Usuario_Id = {id_usuario_logado} {filtro} ")
                   .Append(" order by t.data desc limit 10");

                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(stb.ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TransacaoModel item = new TransacaoModel();
                    item.Id = Convert.ToInt32(dt.Rows[i]["id"]);
                    item.Data = Convert.ToDateTime(dt.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy");
                    item.Valor = Convert.ToDouble(dt.Rows[i]["valor"]);
                    item.Descricao = dt.Rows[i]["historico"].ToString();
                    item.Tipo = dt.Rows[i]["TIPO"].ToString();
                    item.Conta_Id = Convert.ToInt32(dt.Rows[i]["conta_id"]);
                    item.NomeConta = dt.Rows[i]["conta"].ToString();
                    item.Plano_Contas_Id = Convert.ToInt32(dt.Rows[i]["plano_contas_id"]);
                    item.DescricaoPlanoConta = dt.Rows[i]["plano_conta"].ToString();
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + ex.Message + ").");
            }
        }

        public TransacaoModel CarregarRegistro(int id)
        {
            List<TransacaoModel> lista = new List<TransacaoModel>();
            try
            {
                string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
                StringBuilder stb = new StringBuilder();

                stb.Append("select t.id,t.data,t.tipo,t.valor,t.descricao historico,t.conta_id,c.nome conta,t.plano_contas_id, p.descricao plano_conta")
                   .Append(" from transacao t inner join conta c on t.conta_id = c.id")
                   .Append(" inner join plano_contas p on t.plano_contas_id = p.id")
                   .Append($" where t.Usuario_Id = {id_usuario_logado} and t.id = {id}");

                DAL objDAL = new DAL();
                DataTable dt = objDAL.RetDataTable(stb.ToString());

                TransacaoModel item = new TransacaoModel();
                item.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                item.Data = Convert.ToDateTime(dt.Rows[0]["data"].ToString()).ToString("dd/MM/yyyy");
                item.Valor = Convert.ToDouble(dt.Rows[0]["valor"]);
                item.Descricao = dt.Rows[0]["historico"].ToString();
                item.Tipo = dt.Rows[0]["TIPO"].ToString();
                item.Conta_Id = Convert.ToInt32(dt.Rows[0]["conta_id"]);
                item.NomeConta = dt.Rows[0]["conta"].ToString();
                item.Plano_Contas_Id = Convert.ToInt32(dt.Rows[0]["plano_contas_id"]);
                item.DescricaoPlanoConta = dt.Rows[0]["plano_conta"].ToString();
                lista.Add(item);

                return item;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + ex.Message + ").");
            }
        }

        public void Insert()
        {

            try
            {
                string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
                string sql = "";

                if (Id == 0)
                    sql = $"INSERT INTO TRANSACAO (DATA, TIPO, DESCRICAO, VALOR, CONTA_ID, PLANO_CONTAS_ID, USUARIO_ID) VALUES ('{Convert.ToDateTime(Data).ToString("yyyy/MM/dd")}','{Tipo}','{Descricao}','{Valor}',{Conta_Id},{Plano_Contas_Id},{id_usuario_logado})";
                else
                    sql = $"UPDATE TRANSACAO SET DATA = '{Convert.ToDateTime(Data).ToString("yyyy/MM/dd")}', TIPO = '{Tipo}', DESCRICAO = '{Descricao}', VALOR = '{Valor}', CONTA_ID = {Conta_Id}, PLANO_CONTAS_ID = {Plano_Contas_Id} WHERE USUARIO_ID = {id_usuario_logado} AND ID = {Id}";

                DAL objDAL = new DAL();
                objDAL.ExecutarComandoSql(sql);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + ex.Message + ").");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                new DAL().ExecutarComandoSql("DELETE FROM TRANSACAO WHERE ID = " + id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro durante o processo, msg(" + ex.Message + ").");
            }
        }


    }

    public class Dashboard
    {
        public double Total { get; set; }
        public string PlanoConta { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public Dashboard()
        {

        }

        public Dashboard(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<Dashboard> RetornarDadosGraficosPie()
        {

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = "select sum(t.valor) as total, p.Descricao from transacao as t inner join plano_contas as p " +
                         $"on t.Plano_Contas_Id = p.Id where t.Tipo = 'D' and t.usuario_id = {id_usuario_logado} group by p.Descricao";

            List<Dashboard> lista = new List<Dashboard>();

            DAL objDal = new DAL();
            DataTable dt = new DataTable();
            dt = objDal.RetDataTable(sql);

            for(int i=0; i < dt.Rows.Count; i++)
            {
                Dashboard item = new Dashboard();
                item.Total = double.Parse(dt.Rows[i]["Total"].ToString());
                item.PlanoConta = dt.Rows[i]["Descricao"].ToString();
                lista.Add(item);
            }

            return lista;

        }

    }


}
