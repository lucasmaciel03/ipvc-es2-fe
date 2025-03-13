// Syncfusion interop functions
window.loadSyncfusionTheme = function (themeName) {
    // Check if the theme link already exists
    const existingLink = document.getElementById('syncfusion-theme');
    if (existingLink) {
        return;
    }

    // Create a new link element for the Syncfusion theme
    const link = document.createElement('link');
    link.id = 'syncfusion-theme';
    link.rel = 'stylesheet';
    link.href = `_content/Syncfusion.Blazor/styles/bootstrap5.css`;
    document.head.appendChild(link);

    // Add the Syncfusion license key if needed
    // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
};
