# Ecommerce Checkout - xUnit Tests

## Descrição
Projeto de sistema de checkout de e-commerce com testes unitários utilizando xUnit.

## Métodos Implementados

### PedidoService

1. **GerarCodigoRastreio(string regiao, int numeroPedido)**
   - Retorna código de rastreio formatado com região em maiúsculas e número do pedido com 4 dígitos
   - Exemplo: "sudeste", 42 → "SUDESTE-0042"

2. **CalcularPontosFidelidade(int valorTotal)**
   - Calcula pontos de fidelidade (2 pontos a cada R$ 10)
   - Exemplo: 150 → 30 pontos

3. **TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)**
   - Verifica se cliente tem direito a frete grátis (compra ≥ R$ 200 ou cliente VIP)
   - Exemplo: 150, true → true | 150, false → false

## Cobertura de Testes
- ✅ Teste de geração de código de rastreio
- ✅ Teste de cálculo de pontos de fidelidade
- ✅ Teste de frete grátis para cliente VIP
- ✅ Teste de frete grátis para cliente não-VIP

## Instruções de Execução

```bash
# Restaurar dependências
dotnet restore

# Executar testes
dotnet test
