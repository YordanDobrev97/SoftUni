function lockedProfile() {
    const profiles = document.getElementsByClassName('profile');

    Array.from(profiles).forEach(profile => {
        const button = profile.querySelector('button');

        button.addEventListener('click', () => {
            const isLock = profile.querySelector('input').checked;
            const profileDiv = profile.getElementsByTagName('div')[0];

            if (!isLock) { 
                profileDiv.style.display = 'block';
                button.textContent = 'Hide it';
            } else {
                profileDiv.style.display = 'none';
                button.textContent = 'Show more';
            }
        })
    });
}