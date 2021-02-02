using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVCMed.Domain
{
   public class Solicitante
    {
        #region Propriedades

        public Guid IdSolicitante   { get; set; }
        public string Nome          { get; set; }
        public string Cpf           { get; set; }
        public string Telefone      { get; set; }
        public string Email         { get; set; }
        public Guid IdProduto       { get; set; }

        #endregion

        #region Relacionamentos
        public Produto Produto      { get; set; }

        #endregion
    }
}
