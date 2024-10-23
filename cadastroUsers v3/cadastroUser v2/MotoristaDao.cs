using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2
{
    public interface IMotoristaDao
    {
        void AddMotorista(Motorista motorista);
        List<Motorista> GetMotoristas();
        Motorista GetMotorista(int id);
        
    }
}
