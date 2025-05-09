using _17_Propiedades;

public class School
{
	private List<Estudiante> students;

	public School()
	{
		students = new List<Estudiante>();
	}

	public void addStudent(Estudiante nuevoEstudiante)
	{
        students.Add(nuevoEstudiante);
    }

	public bool buscarPorNombre(String name)
	{
		bool encontrado = false;
		int i = 0;

		while (encontrado == false && i < students.Count)
		{
			if (students[i].Nombre.Equals(name))
			{
				encontrado = true;
			}
			else
			{
				i++;
			}
		}

		if(encontrado)
		{
			Console.WriteLine("Nombre: " + students[i].Nombre + "\n"
			+ "Edad: " + students[i].Edad + "\n" 
			+ "Calificacion: " + students[i].Calificacion);
			return false;
		}
		else
		{
			Console.WriteLine("Estudiante no encontrado, intente nuevamente");
			return true;
		}

	}
}
