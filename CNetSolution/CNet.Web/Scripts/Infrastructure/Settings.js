jQuery.namespace("Defero.Settings");

// Current Environment
Defero.Settings.IsDebugEnvironment = window.location.href.indexOf(".com") < 0;
Defero.Settings.IsProductionEnabled = false;

// Language Management
Defero.Settings.LanguageCallbacks = $.Callbacks();
Defero.Settings.CurrentLanguage = "ENG";

// Miscellaneous
Defero.Settings.UseNotifications = true;