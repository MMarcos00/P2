
using _3.Polimorfismo;

Animal[] mascotas = new Animal[]
{
    new Perro("Max"),
    new Gato("Luna"),
    new Pajaro("Piolin")
};


foreach (Animal animal in mascotas)
{
    animal.HacerSonido();
}

