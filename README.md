# Rust FFI Example

An example project that shows the use of Rust's FFI capabilities to handle memory- or performance-senstivie work in Rust while the remainder of the application is written in Unity.

This initial version uses Rust to manage a simple-as-it-gets UDP protocol between a Unity app with a desk bell and a Node server listening for when that bell rings.

Over time, this project can grow to show more available features of both Rust and FFI:

- Custom network protocols in Rust.
- Reading complex data structures into C# from Rust.
- A working game, perhaps?

## What's with the desk bell?

It's from a game called Pit.

## Attributions

- Thanks to "Alexander" and [Orange Free Sounds](http://www.orangefreesounds.com/) for the [desk bell sound](http://www.orangefreesounds.com/desk-bell-sound/).
- Thanks to "BrainyBear" and [3d Warehouse](https://3dwarehouse.sketchup.com/index.html) for the [desk bell model](https://3dwarehouse.sketchup.com/model/u08e270fd-85eb-474b-900f-9a8c35c9a452/Service-Bell).
