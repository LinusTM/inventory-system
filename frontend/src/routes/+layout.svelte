<script lang="ts">
	import { page } from '$app/stores';
	import NavBar from '$lib/shared/components/NavBar.svelte';
	import Email from '$lib/shared/icons/Email.svelte';
	import Github from '$lib/shared/icons/Github.svelte';
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
	<main>
		<slot />
	</main>

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
		<br />
		<br />

		<h3>
			<i>ZBC Ringsted: 2022 - {new Date().getFullYear()}</i>
		</h3>
	</footer>
</div>

<style lang="scss">
	/* VARIABLES */
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

	/* GENERAL TAGS */
	:global(body, html) {
		margin: 0 auto;
		padding: 0 auto;
		background-color: var(--background-primary);
	}

	/* LINKS */
	:global(a:visited, a:link) {
		text-decoration: none;
	}

	:global(svg) {
		vertical-align: text-bottom;
	}

	/* CONTAINER */
	#container {
		display: flex;
		flex-direction: column;
		min-height: 100vh;
		background-color: var(--background-primary);
		color: var(--text-primary);
	}

	/* CONTENT */
	main {
		align-self: center;
		margin: 4rem 6rem;
		font-size: 1.2rem;
		line-height: 1.9;
		flex: 1;
		width: min(800px + 30%, 98%);
	}

	/* FOOTER */
	footer {
		padding: 1.5em;
		font-size: 1rem;
	}

	footer {
		background-color: var(--background-secondary);
		color: var(--text-primary);

		a {
			color: var(--text-primary);
		}

		a:hover {
			border-bottom: 2px solid var(--text-primary);
		}
	}

	:global(.header) {
		text-align: center;
		margin-bottom: 2rem;
		margin-top: 0;
		font-size: 3.1rem;
	}

	:global(*) {
		font-family: 'IBM Plex Sans', sans-serif;
	}
</style>
