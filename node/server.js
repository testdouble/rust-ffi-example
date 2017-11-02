const dgram = require('dgram')
const util = require('util')
const socket = dgram.createSocket('udp4')

socket.on('message', function (message, rinfo) {
  console.log(`---
Received message:
message: ${util.inspect(message)}
rinfo: ${util.inspect(rinfo)}`)
})

socket.bind(12345, () => console.log('Listening...'))
