let prefDark = window.matchMedia('(prefers-color-scheme: dark)');
let prefLight = window.matchMedia('(prefers-color-scheme:light)');
let theme = document.getElementById('body');
let iconChangeMode = document.getElementById('iconDM');


function modeLuncher(_text)
{
    if(_text=='dark')
    {
        theme.classList.remove("lightBody");
        iconChangeMode.innerHTML='🌒';
    }
    else
    {
        theme.classList.add("lightBody");
        iconChangeMode.innerHTML= '☀️';
    }
}

function logoChangeCookie()
{
    if(getCookie('Theme',38)=='dark')
    {
        document.cookie = "Theme=" + "dark" + " expires=Mon, 06 Oct 2025 00:00:00 GMT; path=/";
        setTimeout(modeLuncher('dark'),10);
    }
    else if (getCookie('Theme',38)=='light')
    {
        document.cookie = "Theme=" + "light" + " expires=Mon, 06 Oct 2025 00:00:00 GMT; path=/";
        setTimeout(modeLuncher('light'),10);
    }
}

function logoChangeCookieClick()
{
    document.cookie = "ThemeNav=" + "";
    tmp= getCookie('Theme',38)=='dark' ? 'light' : 'dark'
    document.cookie = "Theme=" +  tmp + " expires=Mon, 06 Oct 2025 00:00:00 GMT; path=/";
    setTimeout(logoChangeCookie,10);
}

function getCookie(_param,_nb)
{
    if (document.cookie.length > 0){
        let listeCookie = document.cookie.split(';');
        let nomCookie = _param + '=';
        let valeurCookie = "";
        for (i=0;i<listeCookie.length;i++){
            if(listeCookie[i].indexOf(nomCookie) != -1)
            {
                valeurCookie = listeCookie[i].substring(nomCookie.length + listeCookie[i].indexOf(nomCookie), (listeCookie[i].length-_nb));
            }
        }
        return valeurCookie;
    }
}

function preferenceTheme()
{
    if(getCookie('Theme',38)!=null)
    {
        if(getCookie('Theme',38).length==1)
        {
            if(window.matchMedia('(prefers-color-scheme: dark)').matches)
            {
                document.cookie = "ThemeNav=" + "dark" + " path=/";
                modeLuncher('dark');
            }
            else
            {
                document.cookie = "ThemeNav=" + "light" + " path=/";
                modeLuncher('light');
            }
        }
    }
    else
    {
        if(window.matchMedia('(prefers-color-scheme: dark)').matches)
        {
            document.cookie = "ThemeNav=" + "dark" + " path=/";
            modeLuncher('dark');
        }
        else
        {
            console.log('bb')
            document.cookie = "ThemeNav=" + "light" + " path=/";
            modeLuncher('light');
        }
    }
}
function preferenceThemeChange()
{
    document.cookie = "Theme=" + "" + " expires=Mon, 06 Oct 2025 00:00:00 GMT; path=/";
    preferenceTheme();
}

preferenceTheme();
prefDark.addEventListener('change', preferenceThemeChange);
prefLight.addEventListener('change', preferenceThemeChange);
iconChangeMode.addEventListener('click',logoChangeCookieClick);
logoChangeCookie();