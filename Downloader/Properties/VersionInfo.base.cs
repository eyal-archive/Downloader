// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VersionInfo.cs" company="Eyal Shilony">
//   Copyright (c) 2012, Eyal Shilony
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#define HG_IS_DIRTY_$DIRTY$

// Major.Minor
[assembly: AssemblyVersion("1.0")]

// Major.Minor.Revision.Build
[assembly: AssemblyFileVersion("1.0.0.$REVNUM$")]

// Major.Minor [Revision as string] [Build Revision Number] ([Source Revision ID][Is dirty?])
#if (HG_IS_DIRTY_1)
[assembly: AssemblyInformationalVersion("1.0 Alpha $REVNUM$ ($REVID$+)")]
#else
[assembly: AssemblyInformationalVersion("1.0 Alpha $REVNUM$ ($REVID$)")]
#endif