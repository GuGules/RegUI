# RegUI

![](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white) ![](https://img.shields.io/badge/Windows%2010-ECE7E8?style=for-the-badge&logo=windows&logoColor=white) ![](https://img.shields.io/badge/Windows_11-EC8AE8?style=for-the-badge&logo=windows-11&logoColor=white)

<img src="logo.png" width="100" height="100">

A simple Docker register manager for Windows. 
Works with latest version of [Docker Registry](https://hub.docker.com/_/registry).

This UI made with C# & WinForms allows users to manage their own public/private docker registry.

This app worked on Windows, and just need to have access to the docker registry. Doesn't need to host it on 
a web server. 

---
### Features

- [x] Access to all repositories of the Docker registry
- [x] Manage (delete) repositories tags
- [x] Copy docker pull command to clipboard
- [x] List tags for a repository
- [x] Generate docker run command

### Oncoming features

- [ ] Manage Docker registry repositories
- [ ] Generate a docker compose
- [ ] Add support for multiples languages (ex: english, espanol, etc...)
- [ ] Add history for run command generation
- [ ] Create website presentation for the app (and maybe online features...)
- [ ] Improve UI to upgrade user experience (maybe with [electronjs](https://www.electronjs.org/))
- [ ] We will see later for more upgrades...

## License
```
MIT License

Copyright (c) 2025 Jules PILLOT

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```


Access to [changelogs](changelogs.md)
