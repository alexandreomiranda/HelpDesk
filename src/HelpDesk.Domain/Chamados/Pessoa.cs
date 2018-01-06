using HelpDesk.Domain.Core.Entity;

namespace HelpDesk.Domain.Chamados
{
    public class Pessoa : Entity<Pessoa>
    {
        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}