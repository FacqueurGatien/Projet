let mainR = document.getElementById('main').getAttribute('name');

switch(mainR)
{
    case 'mainHome':
        document.getElementById('cssMain').setAttribute('href','src/css/home.css');
        break;
    case 'mainEmployes':
        document.getElementById('cssMain').setAttribute('href','src/css/employes.css');
        break;
    case 'mainIntervenants':
        document.getElementById('cssMain').setAttribute('href','src/css/intervenants.css');
        break;
    case 'mainResidents':
        document.getElementById('cssMain').setAttribute('href','src/css/residents.css');
        break;
    case 'mainActivites':
        document.getElementById('cssMain').setAttribute('href','src/css/activites.css');
        break;
    default:
        console.log('error');
        break;
}