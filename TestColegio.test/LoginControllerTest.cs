using ProyectoWeb.Controllers;

namespace TestColegio.test
{
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var login = new LoginController();
            var usuario = new Index() { user = string.Empty };

            var resultado = login.Index(usuario);


        }
    }
}