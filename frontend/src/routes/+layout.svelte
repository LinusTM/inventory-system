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
		href="https://fonts.googleapis.com/css2?family=Bebas+Neue&family=Open+Sans:ital,wght@0,400;0,700;1,400;1,700&display=swap"
		rel="stylesheet"
	/>
</svelte:head>

<!-- Gets the width of the browser -->
<svelte:window bind:innerWidth />

<NavBar />

<!-- Page content -->
<div id="content">
	<slot />
</div>

<footer>
	<p>All rights reserved.</p>
</footer>

<style>
	/* CONTENT */
	#content {
		margin: 8rem 2rem 2rem 2rem;
		font-size: 1.2rem;
		line-height: 1.9;
		background-color: var(--background);
		color: var(--text);
		border-radius: 3px;
		font-family: 'Open Sans', sans-serif;
	}

	/* FOOTER */
	footer {
		bottom: 0;
		width: 100%;
		height: 100%;
		padding: 1.5em;
		font-size: 1rem;
		font-family: 'Open Sans', sans-serif;
		color: var(--text-light);
		background-color: var(--background-dark);
	}
</style>
