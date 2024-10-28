using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEMLKDSB20241028Test
{
    [TestClass]
    public class TestProductoAgape : IDisposable
    {
        private IWebDriver driver;

        public TestProductoAgape()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Blazor()
        {
            driver.Navigate().GoToUrl("https://localhost:7159/product-list");

            System.Threading.Thread.Sleep(1000);

            var btn = driver.FindElement(By.Name("crear"));

            btn.Click();

            System.Threading.Thread.Sleep(1000);

            var nombre = driver.FindElement(By.Id("Nombre"));

            nombre.SendKeys("Hola");

            var descripcion = driver.FindElement(By.Id("Descripcion"));

            descripcion.SendKeys("Mundo");

            var precio = driver.FindElement(By.Id("Precio"));

            precio.SendKeys("1000");


            var guardar = driver.FindElement(By.Name("guardar"));

            guardar.Click();

            System.Threading.Thread.Sleep(1000);

            var regresar = driver.FindElement(By.Name("regresar"));

            regresar.Click();

            System.Threading.Thread.Sleep(1000);
        }

        [TestMethod]
        public void BuscarProducto()
        {
            driver.Navigate().GoToUrl("https://localhost:7159/product-list");

            System.Threading.Thread.Sleep(1000);

            var nombre = driver.FindElement(By.Id("buscar"));

            nombre.SendKeys("Hola");

            System.Threading.Thread.Sleep(1000);

            var buscador = driver.FindElement(By.Name("buscador"));

            buscador.Click();

            System.Threading.Thread.Sleep(1000);
        }
        public void Dispose()
        {

            driver.Quit();
        }

    }
}