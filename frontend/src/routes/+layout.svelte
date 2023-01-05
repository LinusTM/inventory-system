<script lang="ts">
	import { page } from '$app/stores';
	import NavBar from '$lib/shared/components/NavBar.svelte';
	import Email from '$lib/shared/icons/Email.svelte';
	import Github from '$lib/shared/icons/Github.svelte';

	const currentYear = new Date().getFullYear();
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

<div id="container">
	<!-- Navigation bar -->
	<NavBar />

	<!-- Page content -->
	<div id="content">
		<slot />
	</div>

	<!-- Footer -->
	<footer>
		<h3>Kontakt</h3>
		<p><i>Udviklere kan kontaktes ved</i></p>
		<p>
			<a href="mailto:emil148p@zbc.dk">
				<Email />
				emil148p@zbc.dk
			</a>
		</p>

		<p>
			<a href="mailto:linu0108@zbc.dk">
				<Email />
				linu0108@zbc.dk
			</a>
		</p>
		<br />

		<h3>Source koden kan findes her</h3>
		<a href="https://github.com/LinusTM/inventory-system">
			<Github />
			github.com/LinusTM/inventory-system
		</a>
	</footer>
</div>

<style lang="scss">
	/* COLORS */
	:root {
		@media (prefers-color-scheme: light) {
			--background: hsl(0, 0%, 100%);
			--background-medium: hsl(0, 0%, 96%);
			--background-dark: hsl(0, 0%, 11%);
			--background-grayish: hsl(0, 0%, 40%);
			--text: hsl(0, 0%, 0%);
			--text-light: hsl(0, 0%, 100%);
		}

		@media (prefers-color-scheme: dark) {
			--background: hsl(0, 0%, 10%);
			--background-medium: hsl(0, 0%, 16%);
			--background-dark: hsl(0, 0%, 98%);
			--background-grayish: hsl(0, 0%, 60%);
			--text: hsl(0, 0%, 100%);
			--text-light: hsl(0, 0%, 0%);
		}
	}

	/* CONTAINER */
	#container {
		display: flex;
		flex-direction: column;
		min-height: 100vh;
		background-color: var(--background);
		color: var(--text);
	}

	/* CONTENT */
	#content {
		align-self: center;
		margin: 4rem 6rem;
		font-size: 1.2rem;
		line-height: 1.9;
		flex: 1;
		width: min(800px + 30%, 98%);
	}

	footer,
	a {
		@media (prefers-color-scheme: light) {
			color: var(--text-light);
			background-color: var(--background-dark);
		}

		@media (prefers-color-scheme: dark) {
			color: var(--text);
			background-color: var(--background-medium);
		}
	}

	/* FOOTER */
	footer {
		padding: 1.5em;
		font-size: 1rem;
	}

	:global(*) {
		font-family: 'IBM Plex Sans', sans-serif;
	}
</style>
