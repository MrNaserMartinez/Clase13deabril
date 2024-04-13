

using Clase13deabril.ClaseHija;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";
Console.WriteLine(nintendo.MostrarDetalleNintendo());

//instancia de ps1

PlayStation ps = new PlayStation();
ps.Marca = "Play Station 1";
ps.anioLanzamiento = 1994;
ps.ModeloContorlador = "DualSence";
Console.WriteLine($"{ps.MostrarDetallePLay()}");

//instancia de xbox

Xbox xb = new Xbox();
xb.Marca = "xbox 360";
xb.anioLanzamiento = 2005;
xb.Kinect = "Kinetc";
Console.WriteLine($"{xb.MostrarDetalleXbox()}");

//instancia de ps1

SegaDreamCast dg = new SegaDreamCast();
dg.Marca = "SegaDreamCast";
dg.anioLanzamiento = 1990;
dg.PantallaControl = "Pantalla";
Console.WriteLine($"{dg.MostrarDetalleSegaDreamCast()}");


