// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function carregarImagem(event, id) {
    var imagem = event.target.files[0];
    if (imagem) {
        var leitor = new FileReader();
        leitor.onload = function (e) {
            var elementoImagem = document.querySelector(`#imagem_${id}`);
            elementoImagem.style.backgroundImage = `url(${e.target.result})`;
            elementoImagem.style.backgroundSize = 'cover';
        }
        leitor.readAsDataURL(imagem);
    }
}