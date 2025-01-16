document.querySelectorAll('button[target-color]').forEach(button => {
    button.addEventListener('click', () => setColor(button));
});


function setColor(button) {
    const divs = document.querySelectorAll('div.row div.item');

    divs[2].style.backgroundColor = divs[1].style.backgroundColor;
    divs[1].style.backgroundColor = divs[0].style.backgroundColor;
    divs[0].style.backgroundColor = button.getAttribute('target-color');        
}