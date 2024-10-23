using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2
{
    public class MotoristaController
    {
        private readonly IMotoristaDao motoristaDao;

        public MotoristaController(IMotoristaDao motoristaDao)
        {
            this.motoristaDao = motoristaDao;
        }

        public void AddMotorista(string nome, string email, string placa)
        {
            var motorista = new Motorista
            {
                Nome = nome,
                Email = email,
                Placa = placa
            };
            motoristaDao.AddMotorista(motorista);
        }

        public Motorista GetMotorista(int id)
        {
            return motoristaDao.GetMotorista(id);
        }

        public List<Motorista> GetMotoristas()
        {
            return motoristaDao.GetMotoristas();
        }
    }
}
