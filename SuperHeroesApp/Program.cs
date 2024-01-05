
using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var imprimirInfo =new ImprimirInfo();

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Nivel = NivelPoder.NivelTres;



var superman = new SuperHeroe();

superman.Id = 1;
superman.Name = "  Superman  ";
superman.IdentidadSecreta = "Clark Kent";
superman.Cuidad = "Metropolis";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);



List<SuperPoder> superPoderesSuperman = new List<SuperPoder>();
superPoderesSuperman.Add(poderVolar);
superPoderesSuperman.Add(superFuerza);
superman.SuperPoderes = superPoderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

String resultSalvarTierra =superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);



var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Name = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar= false;

imprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);


enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}

public record SuperHeroRecord(
     int Id,
     string Name,
     string IdentidadSecreta
    );