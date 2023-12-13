// Função para carregar a imagem
function carregarImagem(event, produtoId) {
    const file = event.target.files[0];
    const reader = new FileReader();

    reader.onload = function (e) {
        const imagemContainer = document.getElementById(`imagemContainer_${produtoId}`);
        imagemContainer.innerHTML = `<img src="${e.target.result}" class="card-img-top" alt="Imagem do Produto">`;
    };

    reader.readAsDataURL(file);
}