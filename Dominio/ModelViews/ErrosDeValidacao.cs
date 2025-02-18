using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace minimal_api.Dominio.ModelViews;

    public struct ErrosDeValidacao
    {
        public List<string> Mensagens { get; set; }
    }
