using System;

namespace App_Chamados.Exceptions {
    class TrataErros : ApplicationException {
        public TrataErros(string menssagem) : base(menssagem) {

        }
    }
}
