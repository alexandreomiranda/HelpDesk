using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Application.ViewModels
{
    public class ChamadoViewModel : ViewModelBase
    {
        public Guid ID { get; set; }
        public String Descricao { get; set; }
    }
}
