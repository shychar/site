:root {
  --color-bg: #F4F4F4;
  --color-surface: #EAEAEA;
  --color-text: #111111;
  --color-accent: #F5C84C;
  --color-focus: #000000;
  --color-border: #D0D0D0;
  --color-hover-shadow: rgba(0,0,0,0.15);

  --space-xs: 4px;
  --space-sm: 8px;
  --space-md: 16px;
  --space-lg: 24px;
  --space-xl: 48px;
  --space-xxl: 80px;
}

body {
  font-family: 'Source Sans Pro', sans-serif;
  background-color: var(--color-bg);
  color: var(--color-text);
  margin: 0;
}

/* Navigation */
header nav {
  display: flex;
  justify-content: center;
  align-items: center;
  gap: var(--space-lg);
}

/* Cards */
.card {
  background-color: var(--color-surface);
  border-radius: 12px;
  padding: var(--space-md);
  margin-bottom: var(--space-lg);
  transition: transform 0.2s ease, box-shadow 0.2s ease;
}
.card:hover {
  transform: translateY(-4px);
  box-shadow: 0 4px 12px var(--color-hover-shadow);
}
.card:focus-within {
  outline: 3px solid var(--color-focus);
}

/* Stacked UX cards */
.card.stacked {
  display: flex;
  flex-direction: row;
  gap: var(--space-lg);
  align-items: center;
}
.card.stacked .card-image { flex:1; }
.card.stacked .card-text { flex:1; }

@media (max-width: 767px) {
  .card.stacked { flex-direction: column; }
}

/* Gallery */
.gallery {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: var(--space-md);
}
@media (max-width: 1023px) {
  .gallery { grid-template-columns: repeat(2, 1fr); }
}
@media (max-width: 767px) {
  .gallery { grid-template-columns: 1fr; }
}
.gallery img { width: 100%; height: auto; display: block; }

/* Skip link */
.skip-link {
  position: absolute;
  top: -40px;
  left: 0;
  background: var(--color-accent);
  color: var(--color-text);
  padding: var(--space-sm);
  z-index: 100;
}
.skip-link:focus {
  top: var(--space-sm);
}

/* Hero */
.hero {
  display: flex;
  gap: var(--space-xl);
  padding: var(--space-xl);
}
@media (max-width: 767px) {
  .hero { flex-direction: column; }
}
