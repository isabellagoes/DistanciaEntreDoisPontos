double x1, x2, y1, y2, distancia;

Console.WriteLine("Informe os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano cartesiano:\n");

Console.Write("x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("y2: ");
y2 = Convert.ToDouble(Console.ReadLine());
		
distancia = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));

Console.WriteLine($"\nA distância entre os pontos é de: {distancia.ToString("F4")}");