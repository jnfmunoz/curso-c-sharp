using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_TiendaDeGolosinas
{
	public interface IMenu
	{
		void frutas();
		void golosinas();
		void ventas(Almacen almacen);
		double solicitarPago();

	}
}
