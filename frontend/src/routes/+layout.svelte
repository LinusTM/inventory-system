<script lang="ts">
	import { page } from '$app/stores';
	import NavBar from '$lib/shared/components/NavBar.svelte';

	const currentYear = new Date().getFullYear();
	const mobileWidth = 796;

	// Page size
	$: innerWidth = 0;
</script>

<svelte:head>
	<!-- TITLE -->
	<title
		>INVENTAR | {$page.url.pathname === '/'
			? 'SØG'
			: $page.url.pathname.substring(1).toUpperCase()}</title
	>

	<!-- FONTS  -->
	<link rel="preconnect" href="https://fonts.googleapis.com" />
	<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="anonymous" />
	<link
		href="https://fonts.googleapis.com/css2?family=IBM+Plex+Sans:ital,wght@0,400;0,600;1,400;1,600&display=swap"
		rel="stylesheet"
	/>
</svelte:head>

<!-- Gets the width of the browser -->
<svelte:window bind:innerWidth />

<!-- Navigation bar -->
<NavBar />

<!-- Page content -->
<div id="content">
	<slot />
</div>

<footer>
	<h3>Kontakt</h3>
	<p><i>Udviklere kan kontaktes ved</i></p>
	<p>
		<a href="mailto:emil148p@zbc.dk">
			<svg data-testid="geist-icon" fill="none" height="24" shape-rendering="geometricPrecision" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5" viewBox="0 0 24 24" width="24" style="color:var(--geist-foreground)"><path d="M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z"/><path d="M22 6l-10 7L2 6"/></svg>
			emil148p@zbc.dk
		</a>
	</p>

	<p>
		<a href="mailto:linu0108@zbc.dk">
			<svg data-testid="geist-icon" fill="none" height="24" shape-rendering="geometricPrecision" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5" viewBox="0 0 24 24" width="24" style="color:var(--geist-foreground)"><path d="M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z"/><path d="M22 6l-10 7L2 6"/></svg>
			linu0108@zbc.dk
		</a>
	</p>
	<br>

	<h3>Source koden kan findes her</h3>
	<a href="github.com/LinusTM/inventory-system">
		<svg data-testid="geist-icon" fill="none" height="24" shape-rendering="geometricPrecision" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5" viewBox="0 0 24 24" width="24" style="color:var(--geist-foreground)"><path d="M9 19c-5 1.5-5-2.5-7-3m14 6v-3.87a3.37 3.37 0 00-.94-2.61c3.14-.35 6.44-1.54 6.44-7A5.44 5.44 0 0020 4.77 5.07 5.07 0 0019.91 1S18.73.65 16 2.48a13.38 13.38 0 00-7 0C6.27.65 5.09 1 5.09 1A5.07 5.07 0 005 4.77a5.44 5.44 0 00-1.5 3.78c0 5.42 3.3 6.61 6.44 7A3.37 3.37 0 009 18.13V22"/></svg>
		github.com/LinusTM/inventory-system
	</a>
</footer>

<style lang="scss">
	/* CONTENT */
	#content {
		margin: 8rem 2rem 2rem 2rem;
		font-size: 1.2rem;
		line-height: 1.9;
		background-color: var(--background);
		color: var(--text);
		border-radius: 3px;
	}

	/* FOOTER */
	footer {
		bottom: 0;
		width: 100%;
		height: 100%;
		padding: 1.5em;
		font-size: 1rem;
		color: var(--text-light);
		background-color: var(--background-dark);
	}

	:global(*) {
		font-family: 'IBM Plex Sans', sans-serif;
	}
</style>
