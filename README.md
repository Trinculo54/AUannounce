
# AUannounce

Adds custom announcements to impostor without API or client modifications


## Installation 

Have Impostor installed locally

```bash 
 Drag "AUannounce.dll" into your plugins folder, and start the server
```

If its not installed or configured follow this guide

[Impostor Docs](https://github.com/Impostor/Impostor/blob/master/docs/Running-the-server.md)
    
## Custom Announcement

Open your config.json in the root directory

Add AUannounce dependency in your config.json

it should look something like this:
```json
{
  "Server": {
    "PublicIp": "127.0.0.1",
    "PublicPort": 22023,
    "ListenIp": "0.0.0.0",
    "ListenPort": 22023
  },
  "AntiCheat": {
    "Enabled": true,
    "BanIpFromGame": true
  },
  "AUannounce": {
    "Announcement": "EXAMPLE",
    "Enabled": true
  }
}
```
The Announcements follow text mesh pro formatting with you can find [here](http://digitalnativestudios.com/textmeshpro/docs/rich-text/)

  
## Authors

- [@Trinculo54](https://www.github.com/Trinculo54)

  
