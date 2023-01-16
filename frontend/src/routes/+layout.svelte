<script lang="ts">
	import { page } from '$app/stores';
	import NavBar from '$lib/components/NavBar.svelte';
	import Footer from '$lib/components/Footer.svelte';
</script>

<svelte:head>
	<!-- title -->
	<title
		>INVENTAR | {$page.url.pathname === '/'
			? 'SØG'
			: $page.url.pathname.substring(1).toUpperCase()}</title
	>

	<!-- favicon -->
	<link rel="icon" type="image/svg+xml" href="%sveltekit.assets%/favicon.svg" />
	<link rel="icon" type="image/png" href="%sveltekit.assets%/favicon.png" />

	<!-- fonts  -->
	<link rel="preconnect" href="https://fonts.googleapis.com" />
	<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="anonymous" />
	<link
		href="https://fonts.googleapis.com/css2?family=IBM+Plex+Sans:ital,wght@0,400;0,600;1,400;1,600&display=swap"
		rel="stylesheet"
	/>
</svelte:head>

<div id="container">
	<!-- navigation bar -->
	<NavBar />

	<!-- page content -->
	<main>
		<slot />
	</main>

	<!-- footer -->
	<Footer />
</div>

<style lang="scss">
	/* variables */
	:root {
		@media (prefers-color-scheme: light) {
			--background-primary: hsl(0, 0%, 100%);
			--background-secondary: hsl(13, 20%, 96%);
			--background-tertiary: hsl(0, 0%, 11%);
			--background-quaternary: hsl(0, 0%, 40%);
			--text-primary: hsl(0, 0%, 0%);
			--text-secondary: hsl(0, 0%, 100%);
		}

		@media (prefers-color-scheme: dark) {
			--background-primary: hsl(13, 3%, 11%);
			--background-secondary: hsl(13, 3%, 16%);
			--background-tertiary: hsl(0, 0%, 98%);
			--background-quaternary: hsl(0, 0%, 60%);
			--text-primary: hsl(0, 0%, 100%);
			--text-secondary: hsl(0, 0%, 0%);
		}

		--box-shadow: 0 1px 2px hsla(0, 0%, 0%, 0.05), 0 1px 4px hsla(0, 0%, 0%, 0.05),
			0 2px 8px hsla(0, 0%, 0%, 0.05);
	}

	/* general tags */
	:global(body, html) {
		margin: 0 auto;
		padding: 0 auto;
		background-color: var(--background-primary);
		color: var(--text-primary);
	}

	/* links */
	:global(a:any-link) {
		text-decoration: none;
	}

	/* align svg with text */
	:global(svg) {
		vertical-align: text-bottom;
	}

	/* container */
	#container {
		display: flex;
		flex-direction: column;
		min-height: 100vh;
	}

	/* sets the global font family */
	:global(*) {
		font-family: 'IBM Plex Sans', sans-serif;
	}

	/* content */
	main {
		align-self: center;
		margin: 4rem 0;
		font-size: 1.1rem;
		line-height: 1.8;
		flex: 1;
		width: min(800px + 30%, 98%);

		:global(h1:first-of-type) {
			text-align: center;
			margin-bottom: 2rem;
			margin-top: 0;
			font-size: 3rem;
		}
	}
</style>
