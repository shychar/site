// Hamburger Menu Toggle
const hamburger = document.querySelector('.hamburger');
const navMenu = document.getElementById('primary-menu');

hamburger.addEventListener('click', () => {
  const expanded = hamburger.getAttribute('aria-expanded') === 'true';
  hamburger.setAttribute('aria-expanded', !expanded);
  navMenu.classList.toggle('show');
});

// Close menu on Escape or outside click
document.addEventListener('keydown', (e) => {
  if(e.key === 'Escape' && navMenu.classList.contains('show')) {
    navMenu.classList.remove('show');
    hamburger.setAttribute('aria-expanded', 'false');
    hamburger.focus();
  }
});
document.addEventListener('click', (e) => {
  if(!navMenu.contains(e.target) && !hamburger.contains(e.target) && navMenu.classList.contains('show')) {
    navMenu.classList.remove('show');
    hamburger.setAttribute('aria-expanded', 'false');
  }
});

// Gallery Lightbox
const galleryLinks = document.querySelectorAll('.gallery a');
const lightbox = document.createElement('div');
lightbox.id = 'lightbox';
lightbox.setAttribute('aria-modal', 'true');
lightbox.setAttribute('role', 'dialog');
document.body.appendChild(lightbox);

galleryLinks.forEach(link => {
  link.addEventListener('click', e => {
    e.preventDefault();
    lightbox.innerHTML = `<button class='close' aria-label='Close'>×</button><img src='${link.href}' alt='${link.querySelector('img').alt}'>`;
    lightbox.style.display = 'flex';
    lightbox.querySelector('.close').focus();
  });
});

lightbox.addEventListener('click', e => {
  if(e.target === lightbox || e.target.classList.contains('close')) {
    lightbox.style.display = 'none';
  }
});

document.addEventListener('keydown', e => {
  if(e.key === 'Escape' && lightbox.style.display === 'flex') {
    lightbox.style.display = 'none';
  }
});
