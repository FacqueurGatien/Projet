let iconChangeMode = document.getElementById('iconDM');

window.addEventListener('load', 
    function () 
    {
        var theme = localStorage.getItem('theme');
        var body = document.getElementById("body");
        if (theme === null || theme === undefined) {
            theme = 'light';
            localStorage.setItem('theme', theme);
        }
        if(theme=='light')
        {
            body.classList.add('lightBody');
            iconChangeMode.innerHTML= '☀️';
        }
        else
        {
            body.classList.remove('lightBody');
            iconChangeMode.innerHTML='🌒';
        }
    }
 )
 window.matchMedia('(prefers-color-scheme:light)').addEventListener('change', 
 function () 
 {
     var theme = localStorage.getItem('theme');
     if (window.matchMedia('(prefers-color-scheme:light)').matches) 
     {
        theme = 'light';
        localStorage.setItem('theme', theme);
        body.classList.add('lightBody');
        iconChangeMode.innerHTML= '☀️';
     }
 }
)
 window.matchMedia('(prefers-color-scheme:dark)').addEventListener('change', 
 function () 
 {
     var theme = localStorage.getItem('theme');
     if (window.matchMedia('(prefers-color-scheme:dark)').matches) 
     {
        theme = 'dark';
        localStorage.setItem('theme', theme);
        body.classList.remove('lightBody');
        iconChangeMode.innerHTML='🌒';
     }
 }
)
 document.getElementById('iconDM').addEventListener('click' ,
    function switchTheme() {
        var theme = localStorage.getItem('theme');
        var body = document.getElementById('body');
        if (theme === 'light') 
        {
            theme = 'dark';
            body.classList.remove('lightBody');
            iconChangeMode.innerHTML='🌒';
        } 
        else 
        {
            theme = 'light';
            body.classList.add('lightBody');
            iconChangeMode.innerHTML= '☀️';
        }
        localStorage.setItem('theme', theme);
    }
 )