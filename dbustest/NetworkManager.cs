using System;
using DBus;

[Interface ("org.freedesktop.NetworkManager")]
public interface NetworkManager
{
	Device[] GetDevices ();
}
