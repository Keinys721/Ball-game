function skaiciuoti() {
    const vardas = document.getElementById('vardas').value;
    const svoris = document.getElementById('svoris').value;
    const stiklines = document.getElementById('stiklines').value;

    if (vardas && svoris && stiklines) {
        const rekomenduojama = (svoris * 0.03).toFixed(2); // Rekomenduojama vandens norma (3% svorio)
        document.getElementById('rezultatas').innerHTML = vardas + ", Jums rekomenduojama išgerti " + rekomenduojama + " litrų vandens per dieną.";

        const svgContainer = document.getElementById('svg-container');
        svgContainer.innerHTML = stiklines >= 8 ? 
        `<svg xmlns="http://www.w3.org/2000/svg" width="100" height="200" viewBox="0 0 100 200">
          <rect x="20" y="20" width="60" height="160" rx="10" ry="10" fill="none" stroke="black" stroke-width="3"/>
          <rect x="20" y="20" width="60" height="160" fill="url(#waterGradient)" />
          <defs>
            <linearGradient id="waterGradient" x1="0%" y1="0%" x2="0%" y2="100%">
              <stop offset="0%" style="stop-color:lightblue;stop-opacity:0.8" />
              <stop offset="100%" style="stop-color:blue;stop-opacity:0.8" />
            </linearGradient>
          </defs>
          <text x="50" y="195" text-anchor="middle" fill="black" font-size="15" font-weight="bold">Stiklinė pilna</text>
        </svg>` :
        `<svg xmlns="http://www.w3.org/2000/svg" width="100" height="200" viewBox="0 0 100 200">
          <rect x="20" y="20" width="60" height="160" rx="10" ry="10" fill="none" stroke="black" stroke-width="3"/>
          <rect x="20" y="140" width="60" height="40" fill="url(#emptyWaterGradient)" />
          <defs>
            <linearGradient id="emptyWaterGradient" x1="0%" y1="0%" x2="0%" y2="100%">
              <stop offset="0%" style="stop-color:lightblue;stop-opacity:0.6" />
              <stop offset="100%" style="stop-color:lightgray;stop-opacity:0.6" />
            </linearGradient>
          </defs>
          <text x="50" y="195" text-anchor="middle" fill="black" font-size="15" font-weight="bold" >Stiklinė tuščia</text>
        </svg>`;
    } else {
        document.getElementById('rezultatas').innerHTML = "Užpildykite visus laukelius!";
    }
}
