# .NET Service Samples

Samples of various ways to create a .Net Windows Service
with some common patterns for services.

While not comprehensive, each sample will attempt to employ common libraries and practices,
such as logging and dependency injection. The libraries used might vary, the intent
being to show the techniques and not any actual library.

Libraries used:

- [Common.Logging](https://github.com/net-commons/common-logging): A portable
  logging abstraction for .NET. Will be shown in combination with:
  - Log4Net
  - Serilog
  - NLog
- Dependency Injection with
  - [Autofac](https://github.com/autofac/Autofac)
  - [Ninject](https://github.com/ninject/ninject)
  - [Unity Container](https://github.com/unitycontainer/unity)

## Setup Types

### Visual Studio's Windows Service Template

TODO: show multiple services in a single container.

### Topshelf

## Types of Service

### Exposing Service End-points

WCF end-points. ReST end-points.

### Scheduling Service

Using `System.Timers`,
[Quartz.Net](https://www.quartz-scheduler.net/index.html),
[HangFire](https://www.hangfire.io/overview.html),
or [FluentScheduler](https://github.com/fluentscheduler/FluentScheduler).

Talk about: `System.Timers`  vs `System.Threading.Timer`
and drift issues; complex schedules; persistence.

### Message Bus (Consumer)

Using direct listeners vs NServiceBus or MassTransit.
