let buttons = document.querySelectorAll('.navbt');
buttons.forEach(e => {
    e.addEventListener('click', ev => {
        let name = '#' + ev.target.getAttribute('value');
        let el = document.querySelector(name);
        el.scrollIntoView();
    });
});