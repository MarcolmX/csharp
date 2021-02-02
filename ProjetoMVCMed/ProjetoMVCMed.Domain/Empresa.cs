using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVCMed.Domain
{
    public class Empresa
    {
        #region Propriedades

        public Guid IdEmpresa           { get; set; }
        public string RazaoSocial       { get; set; }
        public string CNPJ              { get; set; }
        public string Telefone          { get; set; }
        public string Email             { get; set; }

        #endregion

        #region Relacionamentos
        public List<Produto> Produtos   { get; set; }
        public List<Solicitante> Solicitantes { get; set; }
        #endregion
    }
}
