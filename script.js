// Mobile Navigation
const hamburger = document.querySelector('.hamburger');
const mobileNavLinks = document.querySelector('.nav-links');

hamburger.addEventListener('click', () => {
    mobileNavLinks.style.display = mobileNavLinks.style.display === 'flex' ? 'none' : 'flex';
});

// Smooth Scrolling
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

// Form Submission
const contactForm = document.getElementById('contact-form');
contactForm.addEventListener('submit', function(e) {
    e.preventDefault();
    
    // Get form values
    const name = this.querySelector('input[type="text"]').value;
    const email = this.querySelector('input[type="email"]').value;
    const message = this.querySelector('textarea').value;
    
    // Here you would typically send the form data to a server
    console.log('Form submitted:', { name, email, message });
    
    // Show success message
    alert('Thank you for your message! I will get back to you soon.');
    
    // Reset form
    this.reset();
});

// Scroll Animation
const sections = document.querySelectorAll('section');
const navigationLinks = document.querySelectorAll('.nav-links a');

window.addEventListener('scroll', () => {
    let current = '';
    
    sections.forEach(section => {
        const sectionTop = section.offsetTop;
        const sectionHeight = section.clientHeight;
        if (pageYOffset >= sectionTop - 60) {
            current = section.getAttribute('id');
        }
    });
    
    navigationLinks.forEach(link => {
        link.classList.remove('active');
        if (link.getAttribute('href').slice(1) === current) {
            link.classList.add('active');
        }
    });
});

// Project Gallery Functionality
function initProjectGallery() {
    const mainImage = document.querySelector('.main-image img');
    const thumbnails = document.querySelectorAll('.gallery-thumbs img');
    
    if (!mainImage || !thumbnails.length) return;

    thumbnails.forEach(thumb => {
        thumb.addEventListener('click', () => {
            // Update main image
            mainImage.src = thumb.src;
            
            // Update active state
            thumbnails.forEach(t => t.classList.remove('active'));
            thumb.classList.add('active');
        });
    });
}

// Initialize gallery when DOM is loaded
document.addEventListener('DOMContentLoaded', () => {
    initProjectGallery();
}); 