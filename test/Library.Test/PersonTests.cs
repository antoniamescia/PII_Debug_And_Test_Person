using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person felipe;
        [SetUp]
        public void Setup()
        {
            this.felipe = new Person("Felipe","5.018.412-1");
        }

        [Test]
        public void NameNotNull() // Prueba que el codigo no permite ingresar nombres nulos.
        {
            felipe.Name = null ;
            Assert.IsNotNull(felipe.Name);
        }

        [Test]
        public void NameNotEmpty() // Prueba que el codigo no permite ingresar nombres vacios.
        {
            felipe.Name = "" ;
            Assert.IsNotEmpty(felipe.Name);
        }
        
        [Test]
        public void IdIsValidFunciona() // Prueba que la funcion IdIsValid no permite ingresar Id invalidas.
        {
            string IdIncorrecta = "1.234.567-8";
            felipe.ID = IdIncorrecta ;

            Assert.AreNotEqual(felipe.ID, IdIncorrecta);
        }
    }
}