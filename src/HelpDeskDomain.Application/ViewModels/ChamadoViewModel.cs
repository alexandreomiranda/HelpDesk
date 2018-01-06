using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskDomain.Application.ViewModels
{
    public class ChamadoViewModel : ViewModelBase
    {
        public Guid ID { get; set; }
        public String Descricao { get; set; }
    }
}
