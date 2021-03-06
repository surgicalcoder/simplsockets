SIMPLSOCKETS
===========


A fork of the [official SimplSockets library](https://github.com/haneytron/simplsockets), mainly adapted to use a few changes that may or may not be liked by other people.

**WEB:**   http://www.dache.io

**EMAIL:** [info@dache.io](mailto:info@dache.io)

**NUGET:** [SimplSockets](http://www.nuget.org/packages/SimplSockets)


INSTALLATION INSTRUCTIONS
============================================


Just include the DLL in your project ([NuGet](http://www.nuget.org/packages/SimplSockets)) and then create a SimplSocket!

To create a client or server:

`var client = new SimplSocketClient(...)`

`var server = new SimplSocketServer(...)`

---

`SimplPipelines` is a re-imagining of `SimplSockets` that takes the same protocol and applies "piplines" and "async" concepts
throughout; an example client and server is provided, including a "Kestrel" host.