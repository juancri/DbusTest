using System;
using DBus;
using org.freedesktop.DBus;
using System.Collections.Generic;

[Interface ("org.freedesktop.NetworkManager.Device")]
public interface Device : Introspectable, Properties
{
	void Disconnect ();
}
