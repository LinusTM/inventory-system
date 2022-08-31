<script lang="ts">
	import { page } from '$app/stores';
	import NavBar from '$lib/shared/components/NavBar.svelte';
	import Email from '$lib/shared/icons/Email.svelte';
	import Github from '$lib/shared/icons/Github.svelte';

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

<style lang="scss">
	/* CONTENT */
	#content {
		margin: 4rem 2rem 2rem 2rem;
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
