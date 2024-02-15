document.addEventListener('DOMContentLoaded', function () {
    // Data-alvo para a contagem regressiva (substitua com a sua data desejada)
    var dataAlvo = new Date('2023-12-15T20:00:00');

    function atualizarContagemRegressiva() {
        var agora = new Date();
        var diferenca = dataAlvo - agora;

        var dias = Math.floor(diferenca / (1000 * 60 * 60 * 24));
        var horas = Math.floor((diferenca % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutos = Math.floor((diferenca % (1000 * 60 * 60)) / (1000 * 60));

        document.getElementById('dias').textContent = dias;
        document.getElementById('horas').textContent = horas;
        document.getElementById('minutos').textContent = minutos;
    }

    // Atualiza a contagem regressiva a cada segundo
    setInterval(atualizarContagemRegressiva, 1000);

    // Chama a função pela primeira vez para evitar atraso no início
    atualizarContagemRegressiva();
});
