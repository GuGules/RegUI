const { app, BrowserWindow, Menu } = require('electron')

const template = [
  {
    label: 'Application',
    submenu:[
      {role: 'close',label:'Fermer l\'application'}
    ]
  },
  {
    label: 'Outils',
    submenu: [
      {label: 'Générateur de Docker-Compose'},
      {type: 'separator'},
      {label: 'Ouvrir l\'historique des commandes'}
    ]
  }
]

const createWindow = () => {
    const win = new BrowserWindow({
        width: 800,
        height: 600,
        //titleBarStyle: 'hidden',
        icon: 'src/imgs/logo.png',
        // expose window controls in Windows/Linux
        ...(process.platform !== 'darwin' ? { titleBarOverlay: true } : {})
    })
    


    win.loadFile('src/pages/index.html')
}

const menu = Menu.buildFromTemplate(template)
Menu.setApplicationMenu(menu)

app.whenReady().then(() => {
  createWindow()
})