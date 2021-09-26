using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using testeTempus.Uteis;
using System.Data;


namespace testeTempus.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage="Informe o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Informe o CPF do cliente")]
        public string CPF { get; set; }
        [Required(ErrorMessage="Informe a data de nascimento do cliente")]
        public DateTime DataNascimento { get; set; }
       
        public DateTime DataCadastro { get; set; }
        
        public decimal RendaFamiliar { get; set; }


        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT id, nome, cpf, data_nascimento, data_cadastro, renda_familiar FROM cliente ORDER BY nome ASC";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel()
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    CPF = dt.Rows[i]["CPF"].ToString(),
                    DataNascimento = (DateTime)dt.Rows[i]["DataNascimento"],
                    DataCadastro = (DateTime)dt.Rows[i]["DataCadastro"],
                    RendaFamiliar = (Decimal)dt.Rows[i]["RendaFamiliar"]
                };
                lista.Add(item);

            }
            return lista;
        }

        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;
            DataCadastro = DateTime.Now;
            string dataCadastroFormatada = DataCadastro.ToString("yyyy-MM-dd HH:mm:ss");
            string dataNascimentoFormatada = DataNascimento.ToString("yyyy-MM-dd HH:mm:ss");
            

            if (Id == null)
            {
                sql = $"INSERT INTO cliente(nome, cpf, data_nascimento, data_cadastro, renda_familiar) VALUES ('{Nome}', '{CPF}', '{dataNascimentoFormatada}', '{dataCadastroFormatada}', '{RendaFamiliar}')";
               
            }
            else
            {
                sql = $"UPDATE cliente SET nome = '{Nome}', cpf = '{CPF}', data_nascimento = '{DataNascimento}', renda_familiar='{RendaFamiliar}' WHERE id = '{Id}' ";                
            }
            objDAL.ExecutarComandoSQL(sql);
        }
        


        
        
        
        
        
        
        
    }
}