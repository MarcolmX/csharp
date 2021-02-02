using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVCMed.Domain
{
   public class Produto
    {
        #region Propriedades
        public Guid IdProduto            { get; set; }
        public string Nome               { get; set; }
        public string Preco              { get; set; }
        public string Quantidade         { get; set; }
        public Guid IdSolicitante        { get; set; }
        #endregion

        #region Relacionamentos
        public Solicitante Solicitante   { get; set; }

        #endregion

    }
}
