using Xunit;
using EcommerceCheckout.App;  

namespace EcommerceCheckout.Tests
{
    public class PedidoServiceTests
    {
        private readonly PedidoService _service;

        public PedidoServiceTests()
        {
            _service = new PedidoService();
        }

        [Fact]
        public void GerarCodigoRastreio_DeveRetornarFormatoCorreto()
        {
            string regiao = "sudeste";
            int numeroPedido = 42;

            string resultado = _service.GerarCodigoRastreio(regiao, numeroPedido);

            Assert.Equal("SUDESTE-0042", resultado);
        }

        [Fact]
        public void CalcularPontosFidelidade_DeveCalcularCorretamente()
        {
            int valorTotal = 150;

            int resultado = _service.CalcularPontosFidelidade(valorTotal);

            Assert.Equal(30, resultado);
        }

        [Fact]
        public void TemDireitoAFreteGratis_ClienteVIP_CompraAbaixo200_DeveRetornarTrue()
        {
            int valorTotal = 150;
            bool eClienteVIP = true;

            bool resultado = _service.TemDireitoAFreteGratis(valorTotal, eClienteVIP);

            Assert.True(resultado);
        }

        [Fact]
        public void TemDireitoAFreteGratis_NaoVIP_CompraAbaixo200_DeveRetornarFalse()
        {
            int valorTotal = 150;
            bool eClienteVIP = false;

            bool resultado = _service.TemDireitoAFreteGratis(valorTotal, eClienteVIP);

            Assert.False(resultado);
        }
    }
}