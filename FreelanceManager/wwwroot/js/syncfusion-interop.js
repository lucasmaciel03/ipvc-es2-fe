// Syncfusion interop functions
window.loadSyncfusionTheme = function (themeName = 'material3') {
    // Check if the theme link already exists
    const existingLink = document.getElementById('syncfusion-theme');
    if (existingLink) {
        existingLink.href = `https://cdn.syncfusion.com/blazor/23.1.36/styles/${themeName}.css`;
        return;
    }

    // Create a new link element for the Syncfusion theme
    const link = document.createElement('link');
    link.id = 'syncfusion-theme';
    link.rel = 'stylesheet';
    link.href = `https://cdn.syncfusion.com/blazor/23.1.36/styles/${themeName}.css`;
    document.head.appendChild(link);
};

// Function to initialize Syncfusion components
window.initializeSyncfusion = function () {
    // Add any custom initialization code for Syncfusion components here
    console.log("Syncfusion components initialized with Material3 theme");
    
    // Apply custom styles for Syncfusion components if needed
    const style = document.createElement('style');
    style.textContent = `
        .e-btn {
            text-transform: none;
            font-weight: 500;
        }
        
        .e-sidebar {
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
        }
        
        .e-grid {
            border-radius: 4px;
            overflow: hidden;
        }
    `;
    document.head.appendChild(style);
    
    // Load the Material3 theme by default
    window.loadSyncfusionTheme('material3');
};

// Call initialization on page load
document.addEventListener('DOMContentLoaded', function() {
    window.initializeSyncfusion();
});
